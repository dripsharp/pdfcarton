#nullable disable
#pragma warning disable
﻿namespace CoreJ2K.Util
{
    internal interface IFileInfoCreator
    {
        #region METHODS

        IFileInfo Create(string fileName);

        #endregion
    }
}