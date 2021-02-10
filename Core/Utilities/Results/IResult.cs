using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç

    public interface IResult
    {
        bool Success { get; }    //Başarılı mı başarısız mı diye kontrol amaçlı
        string Message { get; }
    }
}
