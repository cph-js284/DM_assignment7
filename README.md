# DM_assignment7
Design by contract assignment for discretemath

# what is it
Small C# (dotnet core 3.0) console app to work with code contracts. App runs in a docker container.

So right of the bat lets start with a quote:
```
"
We have stopped investing in code contracts a while ago. We've added it to .NET Core 2.0 as part of our compatibility effort, but I wouldn't recommend new code using it.

FWIW, we've looked at many code bases that use them and it seems the overwhelming usage is about null handling. The replacement for this is under way with C# 8's nullable-reference types.
"

- 4.th august 2018, member of dotnet organization (https://docs.microsoft.com/en-us/dotnet/framework/debug-trace-profile/code-contracts)

```

The code contains a couple of references to a tool called CCRewriter, support for this tool was stopped in 2015 (https://marketplace.visualstudio.com/items?itemName=RiSEResearchinSoftwareEngineering.CodeContractsforNET)

The Account class contains both the old syntax (shown in class - not working anymore) and the "new" syntax, which is really just a way to make the tool recognize them as legacy requires statements.

The invariant in this small example is the account balance (Amount variable)

# Make it go
```
sudo docker run -it --rm cphjs284/dmass7:1.0
```

### Extra note
Nullable references type was introduced with C# 8.0, this makes code contract null-handling obsolete.
