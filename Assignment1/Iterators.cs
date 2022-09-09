using System.Linq;

namespace Assignment1;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items) => from item in items
                                                                                  from i in item
                                                                                  select i;

    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) => from item in items
                                                                                            where predicate(item)
                                                                                            select item;

};