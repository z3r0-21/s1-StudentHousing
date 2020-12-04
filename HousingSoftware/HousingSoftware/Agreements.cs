using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSoftware
{
    public class Agreements
    {
        private string agreement;
        private int approveRate;
        private int totalAgree;
        private int totaolDisagree;
        private bool Voted = false;

        public void AddNewAgreement(string suggestedAgreement)
        {
            agreement = suggestedAgreement;
        }

        public void Agree()
        {
            if(Voted == false)
            {
                totalAgree++;
                Voted = true;
            }
        }

        public void Disagree()
        {
            if (Voted == false)
            {
                totaolDisagree++;
                Voted = true;
            }
        }

        public int GetAgreementRatio()
        {
            if(totalAgree != 0 && totaolDisagree != 0)
            {
                approveRate = (totalAgree / totaolDisagree) * 100;
                return approveRate;
            }
            else
            {
                return approveRate = 0;
            }
            
        }

    }
}
