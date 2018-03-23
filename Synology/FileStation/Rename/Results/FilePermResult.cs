﻿using Synology.FileStation.Common.Results;

namespace Synology.FileStation.Rename.Results
{

    /// <summary>
    /// File perm result.
    /// </summary>
    internal class FilePermResult : TaskFilePermResult<FilePermAclResult>, IFilePermResult
	{
        IFilePermAclResult ITaskPermResult<IFilePermAclResult>.Acl => Acl;
    }
}