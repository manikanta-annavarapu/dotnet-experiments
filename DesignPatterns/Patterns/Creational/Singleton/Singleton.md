﻿# Singleton Pattern

## Intent

Ensure a class has only one instance and provide a global point of access to it.

## Problem

Sometimes we need to ensure that a class has only one instance.
For example, we need to have a single instance of a class that controls access to a resource, such as a database connection or a file system.
We also need to ensure that the instance is easily accessible.

## Solution

The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.
The Singleton pattern involves a single class that is responsible for creating its own unique instance and ensuring that no other instances can be created.
The class provides a way to access the instance, usually through a static method.

## Versions of Singleton

There are several versions of the Singleton pattern:
Here in all versions of Singleton, the constructor is private to prevent the creation of instances from outside the class.

<details>
<summary>Not Thread Safe Singleton</summary>
Refer [NotThreadSafeSingleton](./NotThreadSafeSingleton.cs)
Here, the instance is created when the class is loaded.

 | pros | cons |
 | ---- | ---- |
 | Simple to implement | Not thread-safe |

**Why it is not thread safe?**
Consider two threads, T1 and T2, that are executing the `Instance` get method at the same time.
In this case, both threads will see that the instance is null and will create a new instance.
This will result in two instances of the Singleton class.

</details>

<details>
<summary>Simple Thread Safe Singleton</summary>
Refer [SimpleThreadSafeSingleton](./SimpleThreadSafeSingleton.cs)
Here, the instance is created when the class is loaded.

 | pros | cons |
 | ---- | ---- |
 | Thread safe and simple to implement | Performance overhead as the lock mechanism executes every time we request for an instance |

 **Why it is thread safe?**
 The lock mechanism ensures that only one thread can access the `Instance` get method at a time.
 This ensures that only one instance of the Singleton class is created.

 **Why it has performance overhead?**
 The lock mechanism ensures that only one thread can access the `Instance` get method at a time.
 This means that if multiple threads are trying to access the `Instance` get method, they will have to wait for the lock to be released.
 This can cause performance overhead.

 </details>

## Example

Consider a Logger class that logs messages to a file.
We want to ensure that there is only one instance of the Logger class and that all clients use the same instance to log messages.

```csharp
using System;

public class Logger
{
    private static Logger instance;
    private Logger() { }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Logging: {message}");
    }
}
```