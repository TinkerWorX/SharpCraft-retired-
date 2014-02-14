using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.Windows
{
    [Flags]
    public enum ACCESS_TYPE : long
    {
        /// <summary>
        /// The right to delete the object.
        /// </summary>
        DELETE = (0x00010000L),
        /// <summary>
        /// The right to read the information in the object's security descriptor, not including the information in the system access control list (SACL).
        /// </summary>
        READ_CONTROL = (0x00020000L),
        /// <summary>
        /// The right to modify the discretionary access control list (DACL) in the object's security descriptor.
        /// </summary>
        WRITE_DAC = (0x00040000L),
        /// <summary>
        /// The right to change the owner in the object's security descriptor.
        /// </summary>
        WRITE_OWNER = (0x00080000L),
        /// <summary>
        /// The right to use the object for synchronization. This enables a thread to wait until the object is in the signaled state. Some object types do not support this access right.
        /// </summary>
        SYNCHRONIZE = (0x00100000L),

        /// <summary>
        /// Combines DELETE, READ_CONTROL, WRITE_DAC, and WRITE_OWNER access.
        /// </summary>
        STANDARD_RIGHTS_REQUIRED = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER),

        /// <summary>
        /// Currently defined to equal ReadControl.
        /// </summary>
        STANDARD_RIGHTS_READ = (READ_CONTROL),
        /// <summary>
        /// Currently defined to equal ReadControl.
        /// </summary>
        STANDARD_RIGHTS_WRITE = (READ_CONTROL),
        /// <summary>
        /// Currently defined to equal ReadControl.
        /// </summary>
        STANDARD_RIGHTS_EXECUTE = (READ_CONTROL),

        /// <summary>
        /// Combines DELETE, READ_CONTROL, WRITE_DAC, WRITE_OWNER, and SYNCHRONIZE access.
        /// </summary>
        STANDARD_RIGHTS_ALL = (DELETE | READ_CONTROL | WRITE_DAC | WRITE_OWNER | SYNCHRONIZE),

        /// <summary>
        /// All specific rights.
        /// </summary>
        SPECIFIC_RIGHTS_ALL = (0x0000FFFFL),

        ACCESS_SYSTEM_SECURITY = (0x01000000L),

        MAXIMUM_ALLOWED = (0x02000000L),

        /// <summary>
        /// Read access
        /// </summary>
        GENERIC_READ = (0x80000000L),
        /// <summary>
        /// Write access
        /// </summary>
        GENERIC_WRITE = (0x40000000L),
        /// <summary>
        /// Execute access
        /// </summary>
        GENERIC_EXECUTE = (0x20000000L),
        /// <summary>
        /// Read, write, and execute access
        /// </summary>
        GENERIC_ALL = (0x10000000L),
    }
}
