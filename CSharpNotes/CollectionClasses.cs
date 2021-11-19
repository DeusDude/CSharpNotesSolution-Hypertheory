using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class CollectionClasses
    {
        [Fact]
        public void OldSkoolListsDontDoThis()
        {
            var numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Assert.Equal(3, numbers.Count);
            Assert.Equal(2, numbers[1]);
            var firstTwo = (int)numbers[0] + (int)numbers[1];
            // Boxing and Unboxing

            Assert.Equal(3, firstTwo);
        }

        [Fact]
        public void Lists()
        {
            // List of Int
            // Cup<T> 
            var numbers = new List<int>(); // Parametric Polymorphism
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            var firstTwo = numbers[0] + numbers[1];
            Assert.Equal(3, firstTwo);
        }

        [Fact]
        public void EnumeratingAList()
        {
            var numbers = new List<int>(); // Parametric Polymorphism
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            var total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            Assert.Equal(6, total);
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = 0;
            foreach (char letter in "She saidx Hello")
            {
                //if(letter == 'x')
                //{
                //    continue; // or break;
                //}
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            Assert.Equal(5, vowelCount);
        }
        [Fact]
        public void InitializingAndEnumeratingADictionary()
        {
            var scores = new Dictionary<string, int>()
            {
                { "Jeff", 127 },
                {"Violet", 212 },
                {"Henry", 198 },
                { "Stacey", 134}
            };
            Assert.Equal(198, scores["Henry"]);

            foreach(var player in scores.Keys)
            {

            }
            foreach(var score in scores.Values)
            {

            }
            var highScoreName = "";
            var highScore = -1;
            var lowScoreName = "";
            var lowScore = 301;
            foreach(KeyValuePair<string, int> game in scores)
            {
               if(game.Value> highScore)
                {
                    highScore = game.Value;
                    highScoreName = game.Key;
                }
               if(game.Value < lowScore)
                {
                    lowScore = game.Value;
                    lowScoreName = game.Key;
                }
            }

            // Practice: Please tell me the name and score of the high score player and the name and the score of the low score player.
            Assert.Equal("Violet", highScoreName);
            Assert.Equal(212, highScore);
            Assert.Equal("Jeff", lowScoreName);
            Assert.Equal(127, lowScore);
        }

        [Fact]
        public void Dictionaries()
        {
            var friends = new Dictionary<string, string>();

            friends.Add("sean", "Sean Carlin");
            friends.Add("billy", "Bill Farkas");
            friends.Add("sarah", "Sarah Iozzi");

            Assert.Equal("Sean Carlin", friends["sean"]);

            Assert.True(friends.ContainsKey("sean"));
            Assert.False(friends.ContainsKey("nick"));



        }
    }
}
