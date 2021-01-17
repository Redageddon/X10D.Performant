#Documentation Guidelines:
1. Each line has a max size of 150 characters
2. 1 space after each ///
3. Summary is to be multi-lined and has 1 tab + 1 space after the ///
4. Each method parameter is to be documented
5. Each type parameter is to be documented
6. No spaces after the first opening tag
7. No spaces before the last closing tag
8. One period before the last closing tag
9. Order should be: summary, params, types, return, example, exception, see, seealso
10. Declarations of the tags should be in order.
11. No hardcoded types, they should all be references
12. Method overloads that can be inheritdoc should be
13. If method overloads are inheritdoced the larger value should have the documentation declared on EX: with float and double, float should inheritdoc 
from double
14. If method overloads are inheritdoced the paths should be fully defined
15. If a tag is multi line, the documentation should have 1 line after the opening tag, and 1 line before the tag closing
16. If a tag is multiline it should also have 1 tab + 1 space after the ///
17. Documentation of similar types should have similar documentation
18. Void tags should not have a space before the slash
19. Sentences should be capitalized
20. all tpyes should be cref's, no hardcoded types 
21. The returns tag should not begin with the word returns.
22. If a method only has 1 out parameter, it should be called "result"