create view view_MemberIntegral
as
select c.mCardId, c.cardNo,m.mName,c.integralValue,
integralTotal = (select sum(integralValue) from integralRecord i where i.cardNo=c.cardNo and i.integralValue > 0),
usedIntegral = (select sum(integralValue) from integralRecord i where i.cardNo=c.cardNo and i.integralValue < 0)

from memberCard c
inner join member m on c.cardNo=m.cardNo
where c.isDeleted=0