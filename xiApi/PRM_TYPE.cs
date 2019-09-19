using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiApi
{
  public enum PRM_TYPE
  { 
    /// <summary>
    /// Integer parameter type.
    /// </summary>
    TypeInteger,
    /// <summary>
    /// Float parameter type.
    /// </summary>
    TypeFloat,
    /// <summary>
    /// String parameter type.
    /// </summary>
    TypeString,
    /// <summary>
    /// Enumerator parameter type.
    /// </summary>
    TypeEnum,
    /// <summary>
    /// Boolean parameter type.
    /// </summary>
    TypeBoolean,
    /// <summary>
    /// Command parameter type.
    /// </summary>
    TypeCommand
  }
}
