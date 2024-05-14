# Preparing Tea Asynchronously

This program effectively demonstrates how to use asynchronous programming in C# to simulate a real-world process, preparing tea, by asynchronously running the boiling water process and preparing tea cups simultaneously to optimize the overall process.

## Key Points

- Do not `await` a task for it to run parallely
- When the execution stops at an awaited incomplete task the current managed thread is freed and only upon completion of the awaited task a new thread is assigned from the thread pool.
  - To see this in action, uncomment the lines printing current managed thread id before and after the `await boilWaterTask` line.
  - **Case 1:** In case the tea type selection takes longer than boiling water, the awaited task is already complete when encountered and so the current managed thread is the same.
  - **Case 2:** In case the tea type selection is complete before boiling water completes, the awaited task is incomplete and current thread is freed and later when boiling water task completes a thread is obtained from thread pool to continue execution.
