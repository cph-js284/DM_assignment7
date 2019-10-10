//#define CONTRACTS_FULL //<- this command will require the CCRewriter tool to be installed

using System.Diagnostics.Contracts;

namespace DM_assignment7
{
    public class Account
    {
        private double Amount;

        public Account()
        {
            this.Amount = 0.0;
        }

        public void Deposit(double amount){
            //Force the compiler to recognize them as legacy requires statements
            //https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts
            if(amount < 0.0) throw new System.InvalidOperationException("Precondition fail");
            if(amount > double.MaxValue) throw new System.InvalidOperationException("Precondition fail");
            if((amount + this.Amount) > double.MaxValue) throw new System.InvalidOperationException("Precondition fail");

            // Old syntax these commands will require the CC-tool
            // Contract.Requires(amount > 0.0);
            // Contract.Requires(amount < double.MaxValue);
            // Contract.Requires<System.InvalidOperationException>((amount + this.Amount) < double.MaxValue);
            

            Contract.Ensures(this.Amount > 0.0);
            Contract.Ensures(this.Amount < double.MaxValue);
            Contract.EnsuresOnThrow<System.InvalidOperationException>(Contract.OldValue(this.Amount) == this.Amount);
            Contract.EndContractBlock();

            this.Amount += amount;

        }


        public void WithDraw(double amount){
            //Force the compiler to recognize them as legacy requires statements
            //https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts
            if(amount < 0.0) throw new System.InvalidOperationException("Precondition fail");
            if(amount > double.MaxValue) throw new System.InvalidOperationException("Precondition fail");
            if(amount >= this.Amount) throw new System.InvalidOperationException("Precondition fail");

            // 
            // Old syntax these commands will require the CC-tool
            // Contract.Requires(amount > 0.0);
            // Contract.Requires(amount < double.MaxValue);
            // Contract.Requires<System.InvalidOperationException>(amount <= this.Amount);
            

            Contract.EnsuresOnThrow<System.InvalidOperationException>(Contract.OldValue(this.Amount) == this.Amount);
            Contract.Ensures(this.Amount > 0.0);
            Contract.EndContractBlock();

            this.Amount -= amount;
        }

        public double printAmount(){
            return this.Amount;
        }

        [ContractInvariantMethod]
        protected void ObjectInvariant(){
            Contract.Invariant(this.Amount>=0.0);
        }
    }
}