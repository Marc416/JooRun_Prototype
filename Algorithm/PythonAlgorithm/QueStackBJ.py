#import sys
#input = sys.stdin.readline
n = int(input())
stack = []

for _ in range(n):
    s = input().split() #공백을 기준으로 나누어 배열로 만든다
    cmd = s[0]  #첫번째 값은 명령어

    if cmd =="push":
        num = int(s[1])
        stack.append(num)
    elif cmd == 'top':
        if stack:
            print(stack[-1])    
        else :
            print(-1)
    elif cmd == 'size':
        print(len(stack))
    elif cmd =='empty':
        print(0 if stack else 1)
    elif cmd == 'pop':
        if stack:
            print(stack.pop())
        else:
            print(-1)
    
