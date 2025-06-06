using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe.Constants;
using DTO_Models_PolyCafe;
using DBUTIL_Utilities_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_Data_PolyCafe
{
    public class MembershipCardRepository
    {
        public List<MembershipCard> SelectAll()
        {
            string sql = $"SELECT * FROM {DbTables.MembershipCard}";

            List<MembershipCard> cards = Utilities.ExecuteQuery(sql, reader =>
            {
                return new MembershipCard
                {
                    CardId = reader[MembershipCardColumns.CardId].ToString(),
                    CardHolder = reader[MembershipCardColumns.CardHolder].ToString(),
                    Status = Convert.ToBoolean(reader[MembershipCardColumns.Status])
                };
            });

            return cards;
        }


        public int Insert(MembershipCard card)
        {
            string sql = $"INSERT INTO {DbTables.MembershipCard} " +
                        $"({MembershipCardColumns.CardId}, {MembershipCardColumns.CardHolder}, " +
                        $"{MembershipCardColumns.Status}) VALUES (@CardId, @CardHolder, @Status)";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CardId", card.CardId),
                new SqlParameter("@CardHolder", card.CardHolder),
                new SqlParameter("@Status", card.Status)
            };

            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        public int Update(MembershipCard card)
        {
            string sql = $"UPDATE {DbTables.MembershipCard} SET " +
                        $"{MembershipCardColumns.CardHolder} = @CardHolder, " +
                        $"{MembershipCardColumns.Status} = @Status " +
                        $"WHERE {MembershipCardColumns.CardId} = @CardId";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CardId", card.CardId),
                new SqlParameter("@CardHolder", card.CardHolder),
                new SqlParameter("@Status", card.Status)
            };

            return Utilities.ExecuteNonQuery(sql, parameters);
        }

        public int Delete(string cardId)
        {
            string sql = $"DELETE FROM {DbTables.MembershipCard} WHERE {MembershipCardColumns.CardId} = @CardId";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@CardId", cardId)
            };

            return Utilities.ExecuteNonQuery(sql, parameters);
        }


        //Get list of MembershipCard by Criteria
        public List<MembershipCard> GetMembershipCardsByCriteria(string columnName, string value)
        {
            string sql = $"SELECT * FROM {DbTables.MembershipCard} WHERE {columnName} = @Value";
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Value", value)
            };
            List<MembershipCard> cards = Utilities.ExecuteQuery(sql, reader =>
            {
                return new MembershipCard
                {
                    CardId = reader[MembershipCardColumns.CardId].ToString(),
                    CardHolder = reader[MembershipCardColumns.CardHolder].ToString(),
                    Status = Convert.ToBoolean(reader[MembershipCardColumns.Status])
                };
            }, parameters);
            return cards;
        }  
    }
}






















//// Get MembershipCard by CardId --
//public MembershipCard? SelectById(string cardId)
//{
//    return GetMembershipCardsByCriteria(MembershipCardColumns.CardId, cardId).FirstOrDefault() ?? null;
//}


//// Get MembershipCard by Sql --
//public List<MembershipCard> SelectBySql(string sql)
//{
//    return Utilities.ExecuteQuery(sql, reader =>
//    {
//        return new MembershipCard
//        {
//            CardId = reader[MembershipCardColumns.CardId].ToString(),
//            CardHolder = reader[MembershipCardColumns.CardHolder].ToString(),
//            Status = Convert.ToBoolean(reader[MembershipCardColumns.Status])
//        };
//    });
//}



//public string GenerateCardId()
//{
//    string prefix = "THE";
//    string query = $"SELECT {MembershipCardColumns.CardId} FROM {DbTables.MembershipCard} ORDER BY {MembershipCardColumns.CardId} DESC";

//    try
//    {
//        //Get the maximum CardId from the database
//        string lastCardId = Utilities.ExecuteScalar(query)?.ToString() ?? string.Empty;
//        if (string.IsNullOrEmpty(lastCardId))
//        {
//            return prefix + "001";
//        }

//        // Extract the numeric part and increment it
//        string numericPart = lastCardId.Substring(prefix.Length);
//        int nextNumber = int.Parse(numericPart) + 1;
//        return prefix + nextNumber.ToString("D3");
//    }
//    catch (Exception ex)
//    {
//        throw new Exception("Error generating new CardId: " + ex.Message);
//    }
//}