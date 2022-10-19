﻿using System;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;

namespace MoralisUnity.Samples.Shared
{
    /// <summary>
    /// Implemented by <see cref="MoralisTwoWeb3System"/>
    /// </summary>
    public interface ICustomWeb3System 
    {
        //  Properties ------------------------------------
        ICustomWeb3WalletSystem CustomWeb3WalletSystem { set; get; }
        ICustomBackendSystem CustomBackendSystem { set; get; }
        bool HasActiveSession { get; }
        int ChainId { get; }

        //  Methods ---------------------------------------
        string ConvertWeb3AddressToShortFormat(string address);
        UniTask ClearActiveSession();
        
        //  Async Methods ---------------------------------------
        UniTask AuthenticateAsync();
        UniTask<bool> IsAuthenticatedAsync();
        Task<string> GetWeb3UserAddressAsync();
        UniTask<String> ExecuteContractFunctionAsync(string contractAddress, string abi, string functionName, object[] args, bool isLogging = false);
        UniTask<object> RunContractFunctionAsync(string contractAddress, string functionName, string abi, object args, bool isLogging = false);
        UniTask<int> GetNFTsForContractAsync(string contractAddress, bool isLogging = false);


    
    }
}