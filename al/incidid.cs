CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
CancellationToken cancellationToken = cancellationTokenSource.Token;

// Start the asynchronous operation
Task<Special> task = myObject.GetAsync(cancellationToken);

// Cancel the operation if needed
cancellationTokenSource.Cancel();

// Wait for the operation to complete
Special result = await task;
