
using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_UWP
{
    [TestClass]
    public class UnitTest1
    {
        ////----AAA unit Test Priciples----\\\\

        [TestMethod]
        public void Test_GetAdjustedTime()
        {
            //Arrange
            string expected = "video";
            string test_fileName = "file_name.mp4";

            //Act
            string actual =
                PRSapp.ViewModels.TimeViewModel.GetFileType(test_fileName);

            //Assert
            Assert.AreEqual(expected, actual);
            Debug.WriteLine(expected, actual);
        }


        //[TestMethod]
        //public void Test_GetAdjustedTime()
        //{
        //    //Arrange
        //    string expected = "10:30:00 PM";
        //    string _sOut = "10:30:23.1234567";

        //    //Act
        //    PRSapp.ViewModels.TimeViewModel tvm = new PRSapp.ViewModels.TimeViewModel();
        //   //tvm. cant get tyo it???
        //}

        //string GetAdjustedTime(string _sOut)
        //{
        //    string sOut;
        //    sOut = _sOut;
        //    int startPos = 5;
        //    string sub = sOut.Substring(0, 2);
        //    //Check and adjust if hh: change from Single digits(9:) to double digits(10:)
        //    if (!sub.Contains(":"))//"9:" Versus "10"
        //    {
        //        startPos = 6;
        //    }
        //    sub = sOut.Substring(startPos, 2);// --> ss "27"
        //    if (sub != "00" || sOut.Contains("0000 "))
        //    {
        //        //Check and adjust if ss: "27:1234567"(length 10) to " :0000"(length 
        //        if (!sOut.Contains("0000 "))//"10:27:0000 PM"
        //        {
        //            sOut = sOut.Remove(startPos, 10);// --> "9:27: PM" 
        //        }
        //        else
        //        {
        //            sOut = sOut.Remove(startPos, 4);
        //        }
        //        string endChars;
        //        int len = sOut.Length - 2;
        //        endChars = sOut.Substring(len, 2);// --> "PM"
        //        len = sOut.Length - 3;
        //        string holding = sOut.Remove(len, 3);// --> "9:27:"
        //        sOut = holding + "00 " + endChars;// --> "9:27:00 PM"             
        //    }
        //    return sOut;
        //}
    }
}
