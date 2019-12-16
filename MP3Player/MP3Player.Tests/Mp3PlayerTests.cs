using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MP3Player.Tests
{
    [TestClass()]
    public class Mp3PlayerTests
    {
        [TestMethod()]
        public void playSongTest()
        {
            //Arrange
            Mp3Player Mp3Player = new Mp3Player();
            //Act
            string expected = "play MyMp3, null, 0, 0";
            long actual = Mp3Player.play();
            actual.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void openSongTest()
        {
            //Arrange
            Mp3Player Mp3Player = new Mp3Player();
            string file = "test file";
            //Act
            string expected = "open \"test file\" type MPEGVideo alias MyMp3";
            long actual = Mp3Player.open(file);
            actual.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void pauseSongTest()
        {
            //Arrange
            Mp3Player Mp3Player = new Mp3Player();
            //Act
            string expected = "pause MyMp3, null, 0, 0";
            long actual = Mp3Player.pause();
            actual.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void stopSongTest()
        {
            //Arrange
            Mp3Player Mp3Player = new Mp3Player();
            //Act
            string expected = "close MyMp3, null, 0, 0";
            long actual = Mp3Player.stop();
            actual.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
