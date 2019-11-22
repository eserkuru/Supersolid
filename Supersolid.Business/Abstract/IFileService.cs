using System;

namespace Supersolid.Business.Abstract
{
    public interface IFileService
    {
        void CreateSolution(Guid solutionId);
        void CreateProject(Guid projectId);
    }
}
