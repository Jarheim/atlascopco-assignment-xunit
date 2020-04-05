### 1 Bug found
Method ConvertToAtlasCopcoString returns "ERROR:)" when passing 87 as inparameter. Expected result is "Atlas" since 87 is a multiple of 3.

### Setup
.NET Core

> To run the tests 

```shell
$ dotnet test
```

**Methods choosen**
```shell
ConvertToAtlasCopcoString(string toConvert)
ReverseString(string toReverse)
```
