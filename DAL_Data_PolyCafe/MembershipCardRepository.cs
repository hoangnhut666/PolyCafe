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
        public string GenerateCardId()
        {
            string prefix = "THE";
            string query = $"SELECT COUNT(*) FROM {DbTables.MembershipCard}";
            int count = Convert.ToInt32(Utilities.ExecuteScalar(query));
            return prefix + (count + 1).ToString("D4");
        }


        public List<MembershipCard> GetAll()
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
    }
}
