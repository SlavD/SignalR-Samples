using SignalR.Hubs;
using SignalR;
using System;

[HubName("testHub")]
public class TestHub : Hub {

    public static void Notify(string message) {
        var hubContext = GlobalHost.ConnectionManager.GetHubContext<TestHub>();
        hubContext.Clients.notify(DateTime.Now);
    }

    public void Join(string id)
    {
        this.Groups.Add(this.Context.ConnectionId, id);
    }
}
