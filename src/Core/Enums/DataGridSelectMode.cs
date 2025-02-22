// ------------------------------------------------------------------------
// MIT License - Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------

namespace Microsoft.FluentUI.AspNetCore.Components;

public enum DataGridSelectMode
{
    /// <summary>
    /// Allow only one selected row.
    /// </summary>
    Single,

    /// <summary>
    /// Allow only one selected row. Keep selection if same row is clicked.
    /// </summary>
    SingleSticky,

    /// <summary>
    /// Allow multiple selected rows.
    /// </summary>
    Multiple,
}
