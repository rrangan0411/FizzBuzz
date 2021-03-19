using System.Collections.Generic;

namespace FizzBizz.Domain.Logic
{
    public interface IFizzBizzDomain
    {
        IEnumerable<string> EvalList(IEnumerable<object> val);
    }
}