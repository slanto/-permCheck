namespace PermCheck.Tests
{
    using PermCheck.Core;

    using Xunit;

    public class SolutionTest
    {
        [Theory]
        [InlineData(new[] { 4, 1, 3, 2}, 1)]
        [InlineData(new[] { 4, 1, 3 }, 0)]
        [InlineData(new[] { 1, 1 }, 0)]
        public void IsArrayPermutation_ReturnsCorrectValueForGivenArray(int[] array, int expected)
        {
            var sut = new Solution();
            var actual = sut.IsArrayPermutation(array);
            Assert.Equal(expected, actual);
        }
    }
}
