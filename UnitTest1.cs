using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;
namespace TestLab09
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenScoreIs8_LetterIsA ()
        {
            Student s = new Student();
            s.Score = 8;
            Assert.AreEqual('A', s.getLetterScore());
        }
        [TestMethod]
        public void WhenScoreIs7AndHalf_LetterIsB()
        {
            Student s = new Student();
            s.Score = 7.5;
            Assert.AreEqual('B', s.getLetterScore());
        }
        [TestMethod]
        public void WhenScoreIs5_LetterIsC()
        {
            Student s = new Student();
            s.Score = 5;
            Assert.AreEqual('C', s.getLetterScore());
        }
        [TestMethod]
        public void WhenScoreIsBelow3AndHalf_LetterIsE()
        {
            Student s = new Student();
            s.Score = 3.5;
            Assert.AreEqual('C', s.getLetterScore());
        }
    }
}
