echo enter the size of an arr
read s
for((i=0;i<s;i++))
do
read a[$(($i))]
done
echo ${a[@]}

