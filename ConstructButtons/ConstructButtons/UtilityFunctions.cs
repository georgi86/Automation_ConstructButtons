using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructButtons
{
    class ReportAction
    {
        public static void PositiveReport(string Actual)
        {
            string strActualText = "Sucessfully Performed: " + Actual;
            Ranorex.Report.Success(strActualText);
        }

        public static void NegativeReport(string Actual, string Negative)
        {
            string strActualText = "The Actual Value is :" + Actual;
            Ranorex.Report.Error(strActualText);

            string strHardcodedText = "The Expected Text is :" + Negative;
            Ranorex.Report.Error(strHardcodedText);
        }
    }

    class StringCompare
    {
        public static void Text (string Actual, string Hardcoded)
        {
            string strReadText = Actual;
            string strHardcoded = Hardcoded;


            if (strReadText == strHardcoded)
            {
                ReportAction.PositiveReport(strReadText);
            }
            else
            {
                ReportAction.NegativeReport(strReadText, strHardcoded);
            }
        }
    }
}
