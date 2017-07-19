namespace BankLibrary
{
    public interface IAccount
    {
        //положить деньги на счёт
        void Put(decimal sum);

        //взять деньги с счёта
        decimal Withdraw(decimal sum);
    }
}
