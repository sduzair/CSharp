# Avoiding State Machines for Pre-computed Asynchronous

- In `GetRandomJokeWithStateMachine()` method since the result of the asynchronous operation is pre-computed we do not need to que a work item on the thread pool and unnecessarily utilize an additional thread.
- Instead we can use `Task.FromResult()` as in `GetRandomJokeWithoutStateMachine()` method.
