# Anti-Corruption Layer (ACL)

Don't do this:
```lang-none
Consumer                      API                       Back-end
    ^                          |                            ^
    "This is what we need" --->|<--- "This is what we expose" 
```

Do that:
```lang-none
Consumer                  abstraction  AntiCorruptionLayer   API                       Back-end
    ^                          |  Here goes the translation   |                            ^
    "This is what we need" --->|                          --->|<--- "This is what we expose" 

```
