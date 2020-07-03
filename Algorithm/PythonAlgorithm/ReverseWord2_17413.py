'''
import sys
Str = sys.stdin.readline()
ck = False
first = 0

stack =[]

for idx, var in enumerate(Str):
    if not ck and var ==' ':#띄어쓰기가 있다면
        tmp = Str[first:idx][::-1]#Str에서 처음부터 현재까지 찾고
        stack += tmp
        stack.append(var)
        #stack.append(var)
        first = idx+1 #다음 인덱스를 가리킨다
        
print(' '.join(stack))
'''

str = input()
ans = []
first = 0
ck = False
for idx, var in enumerate(str): #전부 한글자씩 자르는 방법
    if not ck and var == ' ':
        tmp = str[first:idx][::-1]
        ans += tmp
        ans.append(var)
        first = idx+1
    elif var == '<':
        tmp = str[first:idx][::-1]
        ans += tmp
        ans.append(var)
        ck=True
    elif var == '>':
        ck=False
        ans.append(var)
        first = idx + 1
    else:
        if ck:
            ans.append(var)
if first != len(str)-1:
    tmp = str[first:len(str)][::-1]
    ans += tmp
print(''.join(ans))
