## How you can contribute
Contributions to this project are always welcome. If you spot a bug, or want to request a new extension method, open a new issue or submit a pull request.

### Pull request guidelines
This project uses C# 9.0 language features.

### Code style
Below are a few pointers to which you may refer, but keep in mind this is not an exhaustive list:

- Use C# 9.0 features where possible
- Try to ensure code is CLS-compliant
- Follow all .NET guidelines for naming conventions
- Make full use of XMLDoc and be thorough - but concise - with all documentation: See [DOCUMENTATION.md](DOCUMENTATION.md)
- Ensure that no line exceeds 150 characters in length
- Do NOT include file headers in any form
- Try to avoid using exceptions for flow control
- Make methods as fast and allocation-less as possible

### Tests
When introducing a new extension method, you must ensure that you have also defined a unit test that asserts its correct behavior. The code style guidelines and code-analysis rules apply to the `X10D.Tests` equally as much as `X10D`, although documentation may be briefer. Refer to existing tests as a guideline.

### Disclaimer
In the event of a code style violation, a pull request may left open (or closed entirely) without merging. Keep in mind this does not mean the theory or implementation of the method is inherently bad or rejected entirely (although if this is the case, it will be outlined)