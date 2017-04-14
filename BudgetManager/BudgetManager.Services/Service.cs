using BudgetManager.Data;

namespace BudgetManager.Services
{
    public abstract class Service
    {
        protected Service()
        {

            this.DbContext = new ApplicationDbContext();
        }
        public ApplicationDbContext DbContext { get;  }
        
    }
}
