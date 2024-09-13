
// Monitor-based lock object
var lockObject = new Object();

lock (lockObject)
{
    // ...
}

// Monitor-based lock object using Monitor
Monitor.Enter(lockObject);
Monitor.Exit(lockObject);


// New System.Threading.Lock object
var l = new Lock();

// Used as lock object (and translated to new Lock by compiler)
lock (l)
{
    // ...
}

lock ((object)l)
{
    // ...
}

// Used like new Lock EnterScope.
using (l.EnterScope())
{
    // ...
}


await MethodAsync();


static async Task MethodAsync()
{
    var l = new Lock();

    using (l.EnterScope())
    {
        await Task.Delay(1000);
    }
}