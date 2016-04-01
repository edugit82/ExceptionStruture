using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DataAccess.Context;
using Model.Model;

namespace ExceptionStructure
{
    public class ExceptionStruct
    {
        #region: Zero parâmetros

        public void ExecuteWithTryVoid(Action delegado)
        {
            this.ActionZeroParameter(delegado);            
        }

        public A ExecuteWithTry<A>(A retorno, Func<A> delegado)
        {
            return this.FuncZeroParameter<A>(retorno, delegado);
        }
        #endregion

        #region: Um parâmetro
        public void ExecuteWithTryVoid<A>(A parametro, Action<A> delegado)
        {
            this.ActionOneParameter<A>(parametro, delegado);            
        }

        public void ExecuteWithTryVoid<A>(ref A parametro, Action<A> delegado)
        {
            this.ActionOneParameter<A>(parametro, delegado);
        }

        public B ExecuteWithTry<A, B>(A parametro, B retorno, Func<A, B> delegado)
        {
            return this.FuncOneParameter<A, B>(parametro, retorno, delegado);            
        }

        public B ExecuteWithTry<A, B>(ref A parametro, B retorno, Func<A, B> delegado)
        {
            return this.FuncOneParameter<A, B>(parametro, retorno, delegado);
        }
        #endregion

        #region: Dois Parâmetros

        public void ExecuteWithTryVoid<A,B>(A parametro,B parametro01, Action<A,B> delegado)
        {
            this.ActionTwoParameter<A, B>(parametro, parametro01, delegado);           
        }

        public void ExecuteWithTryVoid<A, B>(ref A parametro, B parametro01, Action<A, B> delegado)
        {
            this.ActionTwoParameter<A, B>(parametro, parametro01, delegado);
        }

        public void ExecuteWithTryVoid<A, B>(A parametro,ref B parametro01, Action<A, B> delegado)
        {
            this.ActionTwoParameter<A, B>(parametro, parametro01, delegado);
        }
        public void ExecuteWithTryVoid<A, B>(ref A parametro, ref B parametro01, Action<A, B> delegado)
        {
            this.ActionTwoParameter<A, B>(parametro, parametro01, delegado);
        }

        public C ExecuteWithTry<A, B, C>(A parametro, B parametro01, C retorno, Func<A, B, C> delegado)
        {
            return this.FuncTwoParameter<A, B, C>(parametro, parametro01, retorno, delegado);
        }

        public C ExecuteWithTry<A, B, C>(ref A parametro, B parametro01, C retorno, Func<A, B, C> delegado)
        {
            return this.FuncTwoParameter<A, B, C>(parametro, parametro01, retorno, delegado);
        }

        public C ExecuteWithTry<A, B, C>(A parametro,ref B parametro01, C retorno, Func<A, B, C> delegado)
        {
            return this.FuncTwoParameter<A, B, C>(parametro, parametro01, retorno, delegado);
        }

        public C ExecuteWithTry<A, B, C>(ref A parametro,ref B parametro01, C retorno, Func<A, B, C> delegado)
        {
            return this.FuncTwoParameter<A, B, C>(parametro, parametro01, retorno, delegado);
        }
        
        #endregion

        #region: Três parâmetros

        public void ExecuteWithTryVoid<A, B, C>(A parametro, B parametro01, C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(ref A parametro, B parametro01, C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(A parametro,ref B parametro01, C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(A parametro, B parametro01,ref C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(ref A parametro,ref B parametro01, C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(ref A parametro, B parametro01,ref C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(A parametro,ref B parametro01,ref C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C>(ref A parametro,ref B parametro01,ref C parametro02, Action<A, B, C> delegado)
        {
            this.ActionThreeParameter<A, B, C>(parametro, parametro01, parametro02, delegado);
        }

        public D ExecuteWithTry<A, B, C, D>(A parametro, B parametro01, C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(ref A parametro, B parametro01, C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(A parametro,ref B parametro01, C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(A parametro, B parametro01,ref C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(ref A parametro,ref B parametro01, C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(ref A parametro, B parametro01,ref C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(A parametro,ref B parametro01,ref C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        public D ExecuteWithTry<A, B, C, D>(ref A parametro,ref B parametro01,ref C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            return this.FuncThreeParameter<A, B, C, D>(parametro, parametro01, parametro02, retorno, delegado);
        }
        #endregion

        #region: Quatro parâmetros

        public void ExecuteWithTryVoid<A,B,C,D>(A parametro,B parametro01,C parametro02,D parametro03,  Action<A,B,C,D> delegado)
        {
            this.ActionFourParameter<A,B,C,D>(parametro,parametro01,parametro02,parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro, B parametro01, C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro,ref B parametro01, C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro, B parametro01,ref C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro, B parametro01, C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro,ref B parametro01, C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro, B parametro01,ref C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro, B parametro01, C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro,ref B parametro01,ref C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro,ref B parametro01, C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro,B parametro01,ref C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro,ref B parametro01,ref C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro,ref B parametro01, C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(ref A parametro, B parametro01,ref C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }
        public void ExecuteWithTryVoid<A, B, C, D>(A parametro,ref B parametro01,ref C parametro02,ref D parametro03, Action<A, B, C, D> delegado)
        {
            this.ActionFourParameter<A, B, C, D>(parametro, parametro01, parametro02, parametro03, delegado);
        }

        public void ExecuteWithTry<A,B,C,D,E>(A parametro,B parametro01,C parametro02,D parametro03,E retorno,  Func<A,B,C,D,E> delegado)
        {
            this.FuncFourParameter<A,B,C,D,E>(parametro,parametro01,parametro02,parametro03,retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro, B parametro01, C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro,ref B parametro01, C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro, B parametro01,ref C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro, B parametro01, C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro,ref B parametro01, C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro, B parametro01,ref C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro, B parametro01, C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro,ref B parametro01,ref C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro,ref B parametro01, C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro,B parametro01,ref C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro,ref B parametro01,ref C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro,ref B parametro01, C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(ref A parametro, B parametro01,ref C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        public void ExecuteWithTry<A, B, C, D, E>(A parametro,ref B parametro01,ref C parametro02,ref D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            this.FuncFourParameter<A, B, C, D, E>(parametro, parametro01, parametro02, parametro03, retorno, delegado);
        }
        
        #endregion

        #region: ActionParameters

        private void ActionZeroParameter(Action delegado)
        {
            try
            {
                delegado();
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }
        }

        private void ActionOneParameter<A>(A parametro, Action<A> delegado)
        {
            try
            {
                delegado(parametro);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }
        }

        private void ActionTwoParameter<A, B>(A parametro, B parametro01, Action<A, B> delegado)
        {
            try
            {
                delegado(parametro, parametro01);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }
        }

        private void ActionThreeParameter<A, B, C>(A parametro, B parametro01, C parametro02, Action<A, B, C> delegado)
        {
            try
            {
                delegado(parametro, parametro01, parametro02);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }
        }

        private void ActionFourParameter<A, B, C, D>(A parametro, B parametro01, C parametro02, D parametro03, Action<A, B, C, D> delegado)
        {
            try
            {
                delegado(parametro, parametro01, parametro02, parametro03);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }
        }

        #endregion

        #region: FuncParameters

        private B FuncZeroParameter<B>(B retorno, Func<B> delegado)
        {
            try
            {
                retorno = delegado();
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }
            return retorno;
        }

        private B FuncOneParameter<A, B>(A parametro, B retorno, Func<A, B> delegado)
        {
            try
            {
                retorno = delegado(parametro);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }

            return retorno;
        }

        private C FuncTwoParameter<A, B, C>(A parametro, B parametro01, C retorno, Func<A, B, C> delegado)
        {
            try
            {
                retorno = delegado(parametro, parametro01);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }

            return retorno;
        }

        private D FuncThreeParameter<A, B, C, D>(A parametro, B parametro01, C parametro02, D retorno, Func<A, B, C, D> delegado)
        {
            try
            {
                retorno = delegado(parametro, parametro01, parametro02);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }

            return retorno;
        }

        private E FuncFourParameter<A, B, C, D, E>(A parametro, B parametro01, C parametro02, D parametro03, E retorno, Func<A, B, C, D, E> delegado)
        {
            try
            {
                retorno = delegado(parametro, parametro01, parametro02, parametro03);
            }
            catch (Exception e)
            {
                ExceptionxStruct(e);
            }

            return retorno;
        }
        
        #endregion

        #region: Estruturas de exceção

        private void ExceptionxStruct(Exception e)
        {
            using (var context = new ReportErrorsContext())
            {
                var listmodel = new List<ReportErrorsModel>();
                var maxindice = context.ReportErrors.Max(x => x.Id) + 1;
                do
                {
                    listmodel.Add(new ReportErrorsModel()
                    {
                        Id = maxindice,
                        DataHora = DateTime.Now,
                        Message = e.Message,
                        Source = e.Source,
                        StackTrace = e.StackTrace
                    });
                    e = e.InnerException;
                    Thread.Sleep(10);
                } while (e != null);

                context.ReportErrors.AddRange(listmodel);
                context.SaveChanges();
            }
        }

        #endregion

    }
}
