using System.Collections.ObjectModel;
using System.Numerics;

namespace Fibonacci;

public class Model
{
    public ObservableCollection<BigInteger> Numbers { get; } = [0, 1];
}