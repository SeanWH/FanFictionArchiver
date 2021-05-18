// FILE: ISpringControl.cs
// PROJECT: SWH.Controls
// SOLUTION: FanFictionArchiver
// -------------------------------------------
// AUTHOR: Sean Hennessey
// DATE CREATED: 2021-05-18
// DATE MODIFIED: 2021-05-18

namespace SWH.Controls
{
    using System.Drawing;

    public interface ISpringControl
    {
        Size GetPreferredSize(Size constrainingSize);
    }
}