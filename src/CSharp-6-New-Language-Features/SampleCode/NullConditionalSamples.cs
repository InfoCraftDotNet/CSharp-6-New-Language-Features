using System;
using System.ComponentModel;
using System.Text;

namespace SampleCode
{
    public class NullConditionalSamples : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notice our NotifyProperyChange is a little less complex than it was in the NameOf Sample Class
        /// </summary>
        /// <param name="info"></param>
        private void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }


        public void OldNullChecking(InvoiceListDataViewModel currentInvoice)
        {
            var someProxy = new SomeProxy();
            var response = someProxy.SomeMethod();

            if (response != null 
                && response.Result != null 
                && response.Result.Success == SuccessCode.Success)
            {
                Console.WriteLine("Yay!");
            }
        }

        public void UsingNullConditionals(InvoiceListDataViewModel currentInvoice)
        {
            var someProxy = new SomeProxy();
            var response = someProxy.SomeMethod();

            if (response?.Result?.Success == SuccessCode.Success)
            {
                Console.WriteLine("Yay!");
            }

        }
    }

    public enum SuccessCode
    {
        Success,
        Failure
    }

    public class InvoiceListDataViewModel
    {
        public string TableName { get; set; }
        public string JobId { get; set; }
        public DateTime? StatementDate { get; set; }
        public DateTime? TransactionStartDate { get; set; }
        public DateTime? TransactionEndDate { get; set; }
    }

    public class SomeProxy
    {
        public Response SomeMethod()
        {
            throw new NotImplementedException();
        }
    }

    public class Response
    {
        public Result Result { get; set; }
    }

    public class Result
    {
        public SuccessCode Success { get; set; }
    }
}