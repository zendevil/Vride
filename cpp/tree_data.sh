sed -i .bak 's/{/U+007D/g' tree.scm
sed -i .bak 's/"/U+0022/g' tree.scm
sed -i .bak 's/}/U+0022/g' tree.scm
sed -i .bak 's/>/U+003E/g' tree.scm
sed -i .bak 's/</U+003C/g' tree.scm
sed -i .bak 's/</U+003C/g' tree.scm
sed -i .bak 's/;/U+003B/g' tree.scm
#echo "(define data \""|cat - tree.scm > /tmp/out && mv /tmp/out tree.scm
#echo "\")" >> tree.scm
