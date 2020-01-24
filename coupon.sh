


#!?bin/bash -x
random(){
no=$1
return $(($RANDOM%$no))
}

echo how many coupon no required
read count
echo what is the size of it
read size

#i have created a string here
str="1234567890qwertAQWSZXCDERFVBGTYHNMJUIKLOPyuioplkjhgfdsazxcvbnm"
len=${#str}

while(($count>0))
do
s=$size
coupon=""
  while(($s>0))
  do
  random $len
  ran=$?

  #this is the main logic 
  var=${str:$ran:1}
  coupon=$coupon$var

  s=$(($s-1))
  done
echo $coupon
count=$(($count-1))

done

