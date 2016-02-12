using System;

namespace SampleCode
{
    public class ExpressionBodiedMemberSamples
    {
        /// <summary>
        /// Used for calculations
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Calculates the old way
        /// </summary>
        public int Age
        {
            get
            {
                if (BirthDate == default(DateTime)) return 0;
                return DateTime.Now.Year - BirthDate.Year;
            }
        }

        /// <summary>
        /// Uses an expression body
        /// </summary>
        public int AgeWithExpressionBody => 
            BirthDate == default(DateTime) 
            ? 0 
            : DateTime.Now.Year - BirthDate.Year;

        /// <summary>
        /// Uses the old standard Method Body
        /// </summary>
        /// <param name="pdfFile"></param>
        /// <returns></returns>
        public int GetPageCountStandardMethodBody(string pdfFile)
        {
            return PdfReader.Open(pdfFile).PageCount;
        }


        /// <summary>
        /// Uses the new "Expression Body"
        /// </summary>
        /// <param name="pdfFile"></param>
        /// <returns></returns>
        public int GetPageCountExpressionBody(string pdfFile) => 
            PdfReader.Open(pdfFile).PageCount;
    }

    public class PdfReader
    {
        public static PdfFile Open(string pdfFile) => new PdfFile(5);
    }

    public class PdfFile
    {

        public PdfFile(int pageCount) 
        {
            PageCount = pageCount;
        }
        public int PageCount { get; set; }
    }
}