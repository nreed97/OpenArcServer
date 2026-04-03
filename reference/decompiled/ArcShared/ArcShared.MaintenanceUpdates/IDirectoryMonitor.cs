namespace ArcShared.MaintenanceUpdates;

public interface IDirectoryMonitor
{
	event FileSystemEvent Change;

	void Start();
}
