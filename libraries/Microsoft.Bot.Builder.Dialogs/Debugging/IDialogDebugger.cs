﻿using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Bot.Builder.Dialogs.Debugging
{
    public interface IDialogDebugger
    {
        Task StepAsync(DialogContext context, object item, string more, CancellationToken cancellationToken);
    }

    public interface IDebugger
    {
        Task OutputAsync(string text, object item, object value, CancellationToken cancellationToken);
    }
}
