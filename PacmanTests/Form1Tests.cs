using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman_Zagorschi_Franco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Zagorschi_Franco.Tests
{
  [TestClass()]
  public class Form1Tests
  {
    [TestMethod()]
    public void TestFirstPosition()
    {
      Form1 game = new Form1();
      Assert.AreEqual(0,game.next);
    }

    [TestMethod()]
    public void TestMove()
    {
     
    }





  }
}
