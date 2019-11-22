using System;
using System.Collections.Generic;
using System.Text;

namespace Supersolid.Business.Abstract
{
    public interface ICommandService
    {
        void Run(List<string> commands);
    }
}
