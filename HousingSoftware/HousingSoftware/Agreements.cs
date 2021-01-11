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
        private double approveRate;
        private List<int> tenantsAgreed = new List<int>();
        private List<int> tenantsDisagreed = new List<int>();
       

        public string GetAgreement()
        {
            return this.agreement;
        }

        public void AddNewAgreement(string suggestedAgreement)
        {
            agreement = suggestedAgreement;
        }

        public void Agree(int studentNr)
        {
            if (!tenantsAgreed.Contains(studentNr) && !tenantsDisagreed.Contains(studentNr))
            {
                tenantsAgreed.Add(studentNr);
            }
        }

        public void Disagree(int studentNr)
        {
            if (!tenantsAgreed.Contains(studentNr) && !tenantsDisagreed.Contains(studentNr))
            {
                tenantsDisagreed.Add(studentNr);
            }
        }

        public double GetAgreementRatio()
        {
            
                if (tenantsAgreed.Count != 0 && tenantsDisagreed.Count == 0)
                {
                    return approveRate = 100;
                }
                else if (tenantsAgreed.Count != 0 && tenantsDisagreed.Count != 0)
                {
                    approveRate = (Convert.ToDouble(tenantsAgreed.Count) / (Convert.ToDouble(tenantsAgreed.Count) + Convert.ToDouble(tenantsDisagreed.Count))) * 100;
                    return approveRate;
                }
                else
                {
                    return approveRate = 0;
                }
            
        }

        public List<int> GetAgreed()
        {
            return this.tenantsAgreed;
        }

        public List<int> GetDisagreed()
        {
            return this.tenantsDisagreed;
        }

    }
}
