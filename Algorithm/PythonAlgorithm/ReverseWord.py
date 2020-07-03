
import sys


def BOJ_9093():

    orderCount = int(sys.stdin.readline())
    while orderCount > 0:
        orderCount-=1
        line = sys.stdin.readline()
        res=[] 
        for S in line.split():      #문장을 공백단위로 자른 뒤 배열화 시키기       
            for s in S.split():     #자른 문장의 단어를 알파벳단위로 자르기
                res.append(s[::-1]) #s의 처음 부터 끝까지 찾을 텐데
                                    #마지막 부분 부터 1개씩 거꾸로 추출해서 res에 쌓겠다
        print(" ".join(res))        # " ".join( list ) : 리스트에서 문자열로 바꾸겠다                 
                                    #(" "<- 띄어쓰기로 각 요소를 잇겠다)
                                
BOJ_9093()

