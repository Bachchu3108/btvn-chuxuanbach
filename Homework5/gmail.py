from gmail import GMail, Message
import random

reasons = ['troi mua to', 'thoi tiet xau']

reason = random.choice(reasons)

_text = "Hom nay em nghi hoc vi"+reason

mail = GMail('c4e.201708','codethechange')

msg = Message('LY DO NGHI HOC', to = 'bachchu3108@gmail.com',text = _text)

mail.send(msg)
