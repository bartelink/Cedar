namespace Cedar.ProcessManagers
{
    using System;

    public class ProcessCompleted
    {
        public string ProcessId { get; set; }
        public Guid CorrelationId { get; set; }

        public override string ToString()
        {
            return string.Format("Process {0} completed.", ProcessId);
        }
    }
}