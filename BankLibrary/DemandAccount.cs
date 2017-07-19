namespace BankLibrary
{
    //счёт до востробования
    public class DemandAccount : Account
    {
        public DemandAccount(decimal sum, int percentage) : base ( sum, percentage)
        {
        }

        //переопределяе метод добавления счёта
        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs("Открыт новый счет до востребования! Id счета: " + this._id, this._sum));
        }
    }
}
