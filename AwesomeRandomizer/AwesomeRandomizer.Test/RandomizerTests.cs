using System.Collections.Generic;
using Xunit;

namespace AwesomeRandomizer.Test
{
    public class RandomizerTests
    {
        [Fact]
        public void GetRandomWord_NoWords_ReturnsEmptyString()
        {
            //arrange
            Randomizer rand = new Randomizer();
            
            //act
            var randomWord = rand.GetRandomWord("");

            //assert
            Assert.Equal(string.Empty, randomWord);
        }

        [Fact]
        public void GetRandomWord_OneWord_ReturnsTheWord()
        {
            //arrange
            Randomizer rand = new Randomizer();

            //act
            var randomWord = rand.GetRandomWord("Hello");

            //assert
            Assert.Equal("Hello", randomWord);
        }

        [Fact]
        public void GetRandomWord_MultipleWords_ReturnsOneOfTheWords()
        {
            //arrange
            Randomizer rand = new Randomizer();
            var sentence = "Hello there my friend";

            //act
            var randomWord = rand.GetRandomWord(sentence);

            //assert
            Assert.Contains(randomWord, new List<string>() { "Hello", "there", "my", "friend"});
        }
    }
}
