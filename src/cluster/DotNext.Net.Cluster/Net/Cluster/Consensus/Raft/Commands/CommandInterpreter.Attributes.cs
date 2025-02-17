namespace DotNext.Net.Cluster.Consensus.Raft.Commands;

public partial class CommandInterpreter
{
    /// <summary>
    /// Indicates that the method represents command handler.
    /// </summary>
    /// <remarks>
    /// The marked method must have the following signature:
    /// <code>
    /// [CommandHandler]
    /// public async ValueTask MyHandler(MyCommand command, CancellationToken token)
    /// {
    /// }
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    protected sealed class CommandHandlerAttribute : Attribute
    {
        /// <summary>
        /// Indicates that attributed handler is a special handler of snapshot
        /// log entry.
        /// </summary>
        public bool IsSnapshotHandler { get; set; }
    }
}