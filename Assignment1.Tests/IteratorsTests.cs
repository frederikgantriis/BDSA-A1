using Xunit;
using Assignment1;

namespace Assignment1.Tests;

public class IteratorsTests
{
    [Fact]
    public void Given_a_stream_returns_flattenStream()
    {
        // Given
        var stream = new[] { new[] { 'T', 'T', 'T'}, new[] { 'T', 'T', 'T'} };
    
        // When
        var flatten = Assignment1.Iterators.Flatten(stream);
    
        // Then
        Assert.Equal(new[] {'T', 'T', 'T', 'T', 'T', 'T'}, flatten);
    }

    [Fact]
    public void Given_an_intStream_returns_evens()
    {
        // Given
        var stream = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var predicate = new Predicate<int>(i => i % 2 == 0);

        // When
        var filter = Assignment1.Iterators.Filter(stream, predicate);
    
        // Then
        Assert.Equal(new[] {2, 4, 6, 8, 10}, filter);
    }
}