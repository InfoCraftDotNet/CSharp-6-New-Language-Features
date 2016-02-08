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


        public string OldNullChecking(InvoiceListDataViewModel currentInvoice)
        {
            StringBuilder sb = new StringBuilder();
            if (currentInvoice != null)
            {
                if (currentInvoice.TableName != null)
                    sb.AppendLine(currentInvoice.TableName);
                if (currentInvoice.JobId != null)
                    sb.AppendLine(currentInvoice.JobId);
                if (currentInvoice.StatementDate != null)
                    sb.AppendLine(currentInvoice.StatementDate.Value.ToShortDateString());
                if (currentInvoice.TransactionStartDate != null)
                    sb.AppendLine(currentInvoice.TransactionStartDate.Value.ToShortDateString());
                if (currentInvoice.TransactionEndDate != null)
                    sb.AppendLine(currentInvoice.TransactionEndDate.Value.ToShortDateString());
            }
            return sb.ToString();
        }

        public string UsingNullConditionals(InvoiceListDataViewModel currentInvoice)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(currentInvoice?.TableName);
            sb.AppendLine(currentInvoice?.JobId);
            sb.AppendLine(currentInvoice?.StatementDate?.ToShortDateString()
                ?? DateTime.Now.ToShortDateString());
            sb.AppendLine(currentInvoice?.TransactionStartDate?.ToShortDateString()
                ?? DateTime.Now.ToShortDateString());
            sb.AppendLine(currentInvoice?.TransactionEndDate?.ToShortDateString()
                ?? DateTime.Now.ToShortDateString());
            return sb.ToString();
        }
    }

    public class InvoiceListDataViewModel
    {
        public string TableName { get; set; }
        public string JobId { get; set; }
        public DateTime? StatementDate { get; set; }
        public DateTime? TransactionStartDate { get; set; }
        public DateTime? TransactionEndDate { get; set; }
    }
}