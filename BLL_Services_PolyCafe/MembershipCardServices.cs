using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;
using DAL_Data_PolyCafe.Constants;

namespace BLL_Services_PolyCafe
{
    public class MembershipCardServices
    {
        private readonly MembershipCardRepository membershipCardRepository;
        public MembershipCardServices()
        {
            membershipCardRepository = new MembershipCardRepository();
        }

        //Get all membership cards
        public List<MembershipCard> GetAllMembershipCards()
        {
            return membershipCardRepository.SelectAll();
        }

        //Generate a new membership card ID
        public string GenerateCardId()
        {
            return EntityRepository.GenerateId(DbTables.MembershipCard, MembershipCardColumns.CardId, "THE");
        }

        //Add a new membership card
        public int AddMembershipCard(MembershipCard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException(nameof(card), "Membership card cannot be null.");
            }
                
            return membershipCardRepository.Insert(card);
        }

        //Update an existing membership card
        public int UpdateMembershipCard(MembershipCard card)
        {
            if (card == null)
            {
                throw new ArgumentNullException(nameof(card), "Membership card cannot be null.");
            }

            return membershipCardRepository.Update(card);
        }

        //Delete a membership card
        public int DeleteMembershipCard(string cardId)
        {
            if (string.IsNullOrEmpty(cardId))
            {
                throw new ArgumentException("Card ID cannot be null or empty.", nameof(cardId));
            }
            return membershipCardRepository.Delete(cardId);
        }
    }
}
