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
        private List<string> tenantsAgreed = new List<string>();
        private List<string> tenantsDisagreed = new List<string>();
        private int totalDisagree;

        public string GetAgreement()
        {
            return this.agreement;
        }

        public void AddNewAgreement(string suggestedAgreement)
        {
            agreement = suggestedAgreement;
        }

        public void Agree(string tenant, string studentNr)
        {
            if (!tenantsAgreed.Contains(studentNr) && !tenantsDisagreed.Contains(studentNr))
            {
                tenantsAgreed.Add(tenant);
            }
        }

        public void Disagree(string tenant, string studentNr)
        {
            if (!tenantsAgreed.Contains(studentNr) && !tenantsDisagreed.Contains(studentNr))
            {
                tenantsDisagreed.Add(tenant);
            }
        }

        public int GetAgreementRatio()
        {
            
                if (tenantsDisagreed.Count != 0 && tenantsDisagreed.Count == 0)
                {
                    return approveRate = 100;
                }
                else if (tenantsAgreed.Count != 0 && tenantsDisagreed.Count != 0)
                {
                    approveRate = (tenantsAgreed.Count / tenantsDisagreed.Count) * 100;
                    return approveRate;
                }
                else
                {
                    return approveRate = 0;
                }
            
        }

    }
}
