﻿using System.Threading.Tasks;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Eth.DTOs;

namespace Nethereum.RPC.Eth.Blocks
{
    public interface IEthGetBlockWithTransactionsHashesByNumber
    {
        RpcRequest BuildRequest(BlockParameter blockParameter, object id = null);
        RpcRequest BuildRequest(HexBigInteger number, object id = null);
        Task<BlockWithTransactionHashes> SendRequestAsync(BlockParameter blockParameter, object id = null);
        Task<BlockWithTransactionHashes> SendRequestAsync(HexBigInteger number, object id = null);
    }
}