using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class Item
    {
        public int Id { get; }
        public string Name { get; }

        public Item(int id)
        {
            Id = id;
            Name = $"id{id}";
        }
    }
    
    public class SortHelper
    {
        public IEnumerable<Item> Sort(IEnumerable<Item> items)
        {
            return null;
        }
    }
    
    public class SortTests
    {
        [Theory]
        [InlineData(new []{6, 3, 1, 5, 4, 2}, new []{"id1", "id2", "id3", "id4", "id5", "id6"})]
        public void ShouldSort(IEnumerable<int> input, IEnumerable<string> expectedOutput)
        {
            var helper = new SortHelper();
            var sortedItems = helper.Sort(input.Select(index => new Item(index)));
            
            Assert.Equal(expectedOutput, sortedItems.Select(item => item.Name));
        }
    }
}