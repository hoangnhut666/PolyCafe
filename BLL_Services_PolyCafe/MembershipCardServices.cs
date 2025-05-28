using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Data_PolyCafe;
using DTO_Models_PolyCafe;

namespace BLL_Services_PolyCafe
{
    public class MembershipCardServices
    {
        private readonly MembershipCardRepository membershipCardRepository;
        public MembershipCardServices()
        {
            membershipCardRepository = new MembershipCardRepository();
        }
        public List<MembershipCard> GetAllMembershipCards()
        {
            return membershipCardRepository.GetAll();
        }
        //public MembershipCard? GetMembershipCardById(string cardId)
        //{
        //    return membershipCardRepository.GetById(cardId);
        //}
        //public List<MembershipCard> GetActiveMembershipCards()
        //{
        //    return membershipCardRepository.GetActiveCards();
        //}
    }
}
